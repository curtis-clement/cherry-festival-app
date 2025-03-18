<script setup lang="ts">
import { PhHouse, PhWarehouse } from '@phosphor-icons/vue';

</script>

<template>
  <nav>
    <img src="@/assets/icons/ncf-logo-2014.png" alt="Logo" class="logo" />

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
  align-items: center;
  background-color: var(--color-primary-blue);
  display: flex;
  height: 3rem;
  left: 0;
  position: fixed;
  top: 0;
  width: 100%;
}

.logo {
  height: 1.75rem;
  width: 1.75rem;
  margin: 0 1rem;
}

.nav-links {
  align-items: center;
  display: flex;
  height: 100%;
  justify-content: start;
  width: 100%;
}

.nav-links a {
  align-items: center;
  color: var(--color-text-light);
  display: flex;
  gap: 0.5rem;
  text-decoration: none;
  padding: 0 1rem;
}

.nav-links a:hover {
  text-decoration: underline;
}

.nav-links a.router-link-active {
  font-weight: bold;
  text-decoration: underline;
}
</style>