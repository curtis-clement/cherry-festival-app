<script setup lang="ts">
import { RouterLink, RouterView } from 'vue-router'
import { useAuthService } from './services/auth/authService';

const { isAuthenticated } = useAuthService();
</script>

<template>
  <div v-if="isAuthenticated">
    <header>
      <div>Header</div>
    </header>
    <main>
      <RouterView />
    </main>
  </div>
</template>

<style scoped>

</style>
