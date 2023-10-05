// router.js
import { createRouter, createWebHistory } from "vue-router";
import Inlog from "../view/pages/Inlog.vue";
import LiveDataSU from "@/view/pages/LiveDataView.vue";

const routes = [
  {
    path: "/",
    name: "Home",
    component: LiveDataSU,
  },
  {
    path: "/Inlog",
    name: "Inlog",
    component: Inlog,
  },
  // Voeg hier je routes toe
];

const router = createRouter({
  history: createWebHistory(),
  routes,
});

export default router;