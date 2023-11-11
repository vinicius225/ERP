<template>
  <div class="menu">
    <div class="menu-esquerdo">
      <h2 style="color:white; margin-top:10px"><b>MAESTRIA SOFTWARE</b></h2>
      <div class="conteudo-esquerdo">
        <div>
          <img src="@/imgs/undraw_predictive_analytics_re_wxt8.svg" class="img-anuncio" alt="Homem analisando dados">
          <h3>Obtenha os melhores resultados da sua equipe, tudo em um só lugar</h3>
        </div>
      </div>
    </div>
    <div >
      <div class="conteudo">
        <div class="login">
          <a-form
            :model="usuario"
            name="basic"
            :label-col="{ span: 8 }"
            :wrapper-col="{ span: 8 }"
            autocomplete="off"
            @finish="onFinish"
            @finishFailed="onFinishFailed"
          >
          <a-form
            :model="usuario"
            name="basic"
            :label-col="{ span: 8 }"
            :wrapper-col="{ span: 8 }"
            autocomplete="off"
            @finish="onFinish"
            @finishFailed="onFinishFailed"
          >
            <a-form-item
              label="login"
              name="login"
              :rules="[{ required: true, message: 'Please input your login!' }]"
            >
              <a-input v-model:value="usuario.login" />
            </a-form-item>

            <a-form-item
              label="senha"
              name="senha"
              :rules="[{ required: true, message: 'Please input your senha!' }]"
            >
              <a-input-password v-model:value="usuario.senha" />
            </a-form-item>

            <a-form-item name="relembre" :wrapper-col="{ offset: 8, span: 2 }">
              <a-checkbox v-model:checked="usuario.relembre">Lrembre me</a-checkbox>
            </a-form-item>

            <a-form-item :wrapper-col="{ offset: 8, span: 8 }">
              <a-button style="width: 100%;" type="primary" html-type="submit">Logar</a-button>
            </a-form-item>
          </a-form>
          </a-form>
        </div>
      </div>
    </div>
    <footer>
      <div class="footer-content">
        <p>&copy; 2023 - Todos os direitos reservados</p>
        <p>Entre em contato pelo e-mail: contato@exemplo.com</p>
        <nav>
          <ul>
            <li><a href="#">Termos de uso</a></li>
            <li><a href="#">Política de privacidade</a></li>
            <li><a href="#">Sobre nós</a></li>
          </ul>
        </nav>
      </div>
    </footer>
  </div>
</template>

<script setup>
import { reactive } from 'vue'

const usuario = reactive({
  login: '',
  senha: '',
  relembre: true
})
</script>

<style>
body {
  overflow: hidden;
}

.menu {
  display: flex;
  flex-direction: column; /* Alterado para column */
}

.menu-esquerdo,
.menu-direito {
  width: 100%; /* Alterado para 100% */
}

.menu-esquerdo {
  text-align: center;
}

.img-anuncio {
  height: 250px;
  margin-top: 20px; /* Alterado para 20px */
}

.conteudo {
  text-align: center;
  margin-top: 30px; /* Alterado para 30px */
}

.login {
  width: 100%; /* Alterado para 100% */
}
footer {
  position: absolute;
  bottom: 0;
  background-color: rgb(47 46 65);
  color: #FFF;
  width: 100%;
  height: 100px;    
  text-align: center;
  line-height: 100px;
}

</style>