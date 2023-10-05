import { createApp } from "vue";
import { createRouter, createWebHistory } from "vue-router";
import App from "./App.vue";
import "vuetify/styles";
import { createVuetify } from "vuetify";
import * as components from "vuetify/components";
import * as directives from "vuetify/directives";

import Inlog from "./view/pages/Inlog.vue";
import Login from "./view/pages/Login.vue";
import "./global.css";
import router from "../src/router/router";

const app = createApp(App);
app.use(router); // Use the router instance
app.mount("#app");
