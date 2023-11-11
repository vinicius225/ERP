<template>
<div style="height:100%">
<div class="menu">

<Menu/>
</div>
<h1>jgbk</h1>
</div>
</template>

<script setup>
import { ref } from 'vue';
import { useStore } from 'vuex';
import Menu from '@/components/Menu.vue'

const idade = ref(0);
const store = useStore();

const alterNome = () => {
  idade.value++;
  store.commit('setName', 'Novo Nome');
};
</script>
<style scoped>
</style>
