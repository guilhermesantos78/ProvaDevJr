<template>
  <div class="container">
    <div class="Left__container">
      <h3>Lista de Clientes</h3>
      <ul class="Client__list">
        <li v-for="Cliente in Clientes" :key="Cliente.Id" class="Client__item">
          <strong>Id:</strong> {{ Cliente.id }} <br />
          <strong>Nome:</strong> {{ Cliente.nome }} <br />
          <strong>Telefone:</strong> {{ Cliente.telefone }} <br />
          <strong>E-Mail:</strong> {{ Cliente.email }} <br />
          <strong>Endereço De Contato:</strong> {{ Cliente.enderecoDeContato }} <br />
        </li>
      </ul>
    </div>
    <div class="Center__container">
      <h1>ProvaDev</h1>
      <h2>Ocorrências</h2>
    </div>
    <div class="Right__container">
      <form @submit="CreateOcorrencia" class="form">
        <div class="form-group">
          <label for="DataAbertura">Data de Abertura:</label>
          <input type="date" id="DataAbertura" v-model="DataAbertura" />
        </div>

        <div class="form-group">
          <label for="DataDaOcorrencia">Data da Ocorrência:</label>
          <input type="date" id="DataDaOcorrencia" v-model="DataDaOcorrencia" />
        </div>

        <div class="form-group">
          <label for="Descricao">Descrição:</label>
          <input type="text" id="Descricao" v-model="Descricao" />
        </div>

        <div class="form-group">
          <label for="propertyType1">Id do Responsável pela Abertura:</label>
          <select id="propertyType1" v-model="ClienteId1">
            <option v-for="Cliente in Clientes" :key="Cliente.Id" :value="Cliente.id">
              {{ Cliente.nome }} - {{ Cliente.id }}
            </option>
          </select>
        </div>

        <div class="form-group">
          <label for="propertyType2">Id do Responsável pela Ocorrência:</label>
          <select id="propertyType2" v-model="ClienteId2">
            <option v-for="Cliente in Clientes" :key="Cliente.Id" :value="Cliente.id">
              {{ Cliente.nome }} - {{ Cliente.id }}
            </option>
          </select>
        </div>

        <div class="form-group">
          <label for="Conclusao">Conclusão:</label>
          <input type="text" id="Conclusao" v-model="Conclusao" />
        </div>

        <button type="submit" class="submit-btn">Enviar</button>
      </form>
    </div>
  </div>
</template>

<script>
export default {
  name: 'App',
  data() {
    return {
      Clientes: [],
      DataAbertura: '',
      DataDaOcorrencia: '',
      Descricao: '',
      ClienteId1: '',
      ClienteId2: '',
      Conclusao: ''
    };
  },
  methods: {
    async CreateOcorrencia(e) {
      e.preventDefault();

      const data = {
        dataAbertura: this.DataAbertura,
        dataDaOcorrencia: this.DataDaOcorrencia,
        descricao: this.Descricao,
        clienteId1: this.ClienteId1,
        clienteId2: this.ClienteId2,
        conclusao: this.Conclusao
      };

      const dataJson = JSON.stringify(data);

      const response1 = await fetch('https://localhost:7203/Ocorrencia/adicionar-ocorrencia', {
        method: 'POST',
        headers: { 'Content-Type': 'application/json' },
        body: dataJson,
      });

      if (response1.status === 200) {
        alert('Ocorrência enviada com sucesso');
      } else {
        alert('Ocorreu um erro ao enviar a ocorrência');
      }
    },

    async GetClientes() {
      try {
        const response2 = await fetch('https://localhost:7203/Cliente/listar-cliente', {
          method: 'GET',
          headers: { 'Content-Type': 'application/json' }
        });

        this.Clientes = await response2.json();
      } catch (error) {
        console.error('Erro ao buscar clientes:', error);
      }
    }
  },
  created() {
    this.GetClientes();
  },
};
</script>


<style>
.container {
  display: flex;
}

.Left__container {
  flex: 1;
  display: flex;
  flex-direction: column;
  justify-content: center;
  align-items: center;
}

.Center__container {
  flex: 1;
  display: flex;
  flex-direction: column;
  justify-content: center;
  align-items: center;
}

.Right__container {
  flex: 1;
  display: flex;
  flex-direction: column;
  justify-content: center;
  align-items: center;
  padding: 20px;
}

h1,
h2 {
  color: #3e3e3e;
  margin-bottom: 10px;
}

h3 {
  color: #3e3e3e;
  font-size: 1.2em;
  margin-bottom: 5px;
}

.Client__list {
  display: flex;
  flex-direction: column;
  gap: 20px;
}

.Client__item {
  list-style-type: none;
  background-color: #ededed;
  padding: 20px;
  border-radius: 8px;
}

.form-group {
  margin-bottom: 20px;
}

.form-group label {
  font-size: 1.1rem;
  color: #666;
  margin-bottom: 8px;
}

.form-group input {
  width: 100%;
  padding: 15px;
  border: 2px solid #ddd;
  border-radius: 8px;
  font-size: 1rem;
  background-color: #f9f9f9;
  color: #333;
  transition: all 0.3s ease;
}

.form-group input:focus {
  border-color: #1c92d2;
  background-color: #fff;
}

.submit-btn {
  width: 100%;
  padding: 12px;
  background-color: rgb(0, 43, 82);
  color: white;
  border: none;
  border-radius: 8px;
  font-size: 1.1rem;
  cursor: pointer;
  transition: background-color 0.3s ease;
}

.submit-btn:hover {
  background-color: #1A5276;
}

input[type="date"],
input[type="text"],
input[type="number"] {
  width: 100%;
  padding: 10px;
  border-radius: 5px;
  border: 1px solid #ccc;
  margin-top: 5px;
  font-size: 1em;
}

</style>
