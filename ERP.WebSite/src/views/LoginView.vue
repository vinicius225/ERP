<template>
  <div class="conteudo">
    <header>
      <h2><b>MAESTRIA SOFTWARE</b></h2>
      <img src="@/imgs/undraw_predictive_analytics_re_wxt8.svg" alt="" class="img-logo" />
    </header>
    <div class="formulario">
    <a-form
    :model="usuario"
    name="normal_login"
    class="login-form"
    @finish="onFinish"
    @finishFailed="onFinishFailed"
  >
    <a-form-item
      label="Login"
      name="login"
      :rules="[{ required: true, message: 'Please input your username!' }]"
    >
      <a-input v-model:value="usuario.login">
        <template #prefix>
          <UserOutlined class="site-form-item-icon" />
        </template>
      </a-input>
    </a-form-item>

    <a-form-item
      label="Senha"
      name="senha"
      :rules="[{ required: true, message: 'Please input your password!' }]"
    >
      <a-input-password v-model:value="usuario.senha">
        <template #prefix>
          <LockOutlined class="site-form-item-icon" />
        </template>
      </a-input-password>
    </a-form-item>

    <a-form-item>
      <a-form-item name="lembre-me" no-style>
        <a-checkbox v-model:checked="usuario.lembre">Remember me</a-checkbox>
      </a-form-item>
      <a class="login-form-forgot" href="">Forgot password</a>
    </a-form-item>

    <a-form-item>
      <a-button :disabled="disabled" type="primary" html-type="submit" @click="logar"  class="login-form-button">
        Log in
      </a-button>
      Or
      <a href="">register now!</a>
    </a-form-item>
  </a-form>
</div>
    <footer>
      <p>&copy; 2023 - Todos os direitos reservados</p>
    </footer>
  </div>
</template>

<script setup>
import { reactive } from 'vue'
import API from '@/api/usuario'
import { UserOutlined, InfoCircleOutlined } from '@ant-design/icons-vue'

const usuario = reactive({
  login: '',
  senha: '',
  relembre: true
})
function logar(){
  debugger
API.usuario.autenticar(this.usuario).then((result)=>{

}).catch((error)=>{
  console.log(error)
})
}
</script>

<style>

.formulario{
width: 70vh;
margin-top: 3vh;
margin-left: auto; 
margin-right: auto;
}
body {
  overflow: hidden;
}
h2 {
  text-align: center;
}
footer {
  background-color: #333;
  color: #fff; 
  text-align: center;
position: absolute;
bottom: 0;
left: 0;
}
.conteudo {
  margin-left: auto;
  margin-right: auto;



}
.form{
  display: inline;
}
.img-logo {
  height: 200px;
  width: 300px;
  margin-top: 40px;
  margin-left: auto;
  margin-right: auto;
  display: flex;
  justify-content: center;

}
@media screen  and  (max-width: 600px){
  .img-logo {
    height: 300px;
    width: 300px;
    margin-top: 40px;
  }
}
footer {
  display: block;
  position: absolute;
  bottom: 0;
  background-color: rgb(47 46 65);
  color: #fff;
  width: 100%;
  height: 6%;
  text-align: center;
}
</style>