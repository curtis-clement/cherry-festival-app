<script setup lang="ts">
import { PhHouse, PhWarehouse } from '@phosphor-icons/vue';

</script>

<template>
  <nav>
    
    <div class="nav-links">
      <RouterLink to="/">
        <PhHouse :size="16" />Home
      </RouterLink>
      <RouterLink :to="{ name: 'warehouse' }">
        <PhWarehouse :size="16" />Warehouse
      </RouterLink>
    </div>
  </nav>
</template>

<style scoped>
nav {
  width: 100%;
  position: fixed;
  top: 0;
  left: 0;
  height: 3rem;
  background-color: var(--color-primary-blue);
}

.nav-links {
  display: flex;
  justify-content: space-between;
  align-items: center;
  height: 100%;
  padding: 0 1rem;
}

.nav-links a {
  color: var(--color-text-light);
  text-decoration: none;
  display: flex;
  align-items: center;
  gap: 0.5rem;
}

.nav-links a:hover {
  text-decoration: underline;
}

.nav-links a.router-link-active {
  text-decoration: underline;
  font-weight: bold;
}
</style>