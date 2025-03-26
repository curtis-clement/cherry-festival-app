<script setup lang="ts">
import { ref } from 'vue';
import warehouseApi from '@/services/api';

const sectionName = ref('');
const sectionDescription = ref('');

const getAllSections = async () => {
  const sections = await warehouseApi.getAllSections();
  console.log('SECTIONS', sections);
};

const createSection = async () => {
  const section = await warehouseApi.createSection({
    name: sectionName.value,
    description: sectionDescription.value
  });
  console.log('SECTION', section);
};
</script>

<template>
  <div>
    <h1>Warehouse</h1>
    <button @click="getAllSections">Get All Sections</button>
  </div>

  <form @submit.prevent="createSection">
    <input type="text" v-model="sectionName" placeholder="Name" />
    <input type="text" v-model="sectionDescription" placeholder="Description" />
    <button type="submit">Create Section</button>
  </form>
</template>