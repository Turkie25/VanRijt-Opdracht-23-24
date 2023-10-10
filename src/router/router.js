// router.js
import { createRouter, createWebHistory } from "vue-router";
import Login from "../view/pages/Login.vue";
import LiveDataSU from "@/view/pages/LiveDataView.vue";

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
  // Voeg hier je routes toe
];

const router = createRouter({
  history: createWebHistory(),
  routes,
});

export default router;