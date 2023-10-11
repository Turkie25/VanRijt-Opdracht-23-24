// router.js
import { createRouter, createWebHistory } from "vue-router";
import Login from "../view/pages/Login.vue";
import Example from "../view/pages/Example.vue";
import LiveDataView from "@/view/pages/LiveDataView.vue";

const routes = [
  {
    path: "/",
    name: "LiveDataView",
    component: LiveDataView
  },
  {
    path: "/Login",
    name: "Login",
    component: Login,
  },
  {
    path: "/example",
    name: "Example",
    component: Example,
  },
  // Voeg hier je routes toe
];

const router = createRouter({
  history: createWebHistory(),
  routes,
});

export default router;