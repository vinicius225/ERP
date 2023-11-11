// Certifique-se de importar a função autenticacao, se existir
// import autenticacao from 'caminho/para/autenticacao'; // Substitua o caminho real

import axios from "axios";
import usuario from "/src/api/usuario.js";
import store from "/src/store/index.js"; 

const instance = axios.create({ baseURL: 'https://seu-url-base-da-api' });
instance.defaults.timeout = 1200000; 
instance.defaults.headers.post["Content-Type"] = "application/json";
instance.defaults.headers.put["Content-Type"] = "application/json";

instance.interceptors.request.use((config) => { 
    if (store.state.autenticacao.token) {
        config.headers["Authorization"] = `Bearer ${store.state.autenticacao.token}`;
    }
    return config; 
});

// Se autenticacao for uma função, você pode chamar a função aqui
// const configuracaoAutenticacao = autenticacao({ usuario });
// export default { ...configuracaoAutenticacao };

// Se autenticacao for um objeto diretamente, apenas exporte-o
export default { 
    // Substitua esta linha conforme necessário com o objeto de autenticacao
    // autenticacao: { ... },
    ...usuario,
};
