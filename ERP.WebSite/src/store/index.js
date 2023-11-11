import {createStore} from 'vuex'
const index = createStore(
    {
state : {
    login :{
        nome : 'Vinicius'
    }
},
mutations :{
    setName(state, login){
        state.login.nome = login
    }
}
})

export default index