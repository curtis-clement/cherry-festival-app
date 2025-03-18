<script setup lang="ts">
import { RouterLink, RouterView } from 'vue-router'
import { useAuthService } from './services/auth/authService';
import NavBar from '@/components/NavBar.vue';

const { isAuthenticated } = useAuthService();
</script>

<template>
  <div v-if="isAuthenticated">
    <NavBar />
    <main>
      <RouterView />
    </main>
  </div>
</template>

<style scoped>

</style>
