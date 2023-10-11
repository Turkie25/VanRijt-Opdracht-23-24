// router.js
import { createRouter, createWebHistory } from "vue-router";
import Login from "../view/pages/Login.vue";
import LiveDataSU from "@/view/pages/LiveDataView.vue";
import Grafiek from "@/view/pages/Grafiek.vue";

const routes = [
  {
    path: "/",
    name: "Login",
    component: Login,
  },
  {
    path: "/comp",
    name: "components",
    component: LiveDataSU,
  },
  {
    path: "/Grafiek",
    name: "Grafiek",
    component: Grafiek,
  },
  // Voeg hier je routes toe
];

const router = createRouter({
  history: createWebHistory(),
  routes,
});

export default router;