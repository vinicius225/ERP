import { createStore } from 'vuex';

const store = createStore({
  modules: {
    autenticacao: {
      state: {
        login: 'Vinicius',
        senha: '',
        token: ''
      },
      mutations: {
        setName(state, novoLogin) {
          state.login = novoLogin;
        }
      }
    }
  }
});

export default store;
