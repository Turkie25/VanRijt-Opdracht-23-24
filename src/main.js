import { createApp } from "vue"; // Correct import for Vue
import App from "./App.vue"; // Import your root component
import "./global.css";
import router from "../src/router/router";

const app = createApp(App);
app.use(router); // Use the router instance
app.mount("#app");
