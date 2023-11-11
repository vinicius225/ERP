<template>
  <main>
    {{ $store.state.autenticacao.login }}
  </main>
</template>

<script setup>
import { ref } from 'vue';
import { useStore } from 'vuex';
const store = useStore();
const idade = ref(0);


const alterNome = () => {
  idade.value++;
  store.commit('setName', 'Novo Nome');
};
</script>
