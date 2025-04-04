import './assets/main.css'

import { createApp } from 'vue';
import { createPinia } from 'pinia';
import { auth0Plugin } from '@/services/auth/auth0Config';

import App from './App.vue'
import router from './router/router'

const app = createApp(App)

app.use(createPinia())
app.use(router)
app.use(auth0Plugin)

app.mount('#app')
