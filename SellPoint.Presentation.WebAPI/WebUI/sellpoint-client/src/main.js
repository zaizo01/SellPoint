import { createApp } from "vue";
import App from "./App.vue";
import router from "./router";
import "./styles/styles.scss";
import VueSweetalert2 from "vue-sweetalert2";
import "sweetalert2/dist/sweetalert2.min.css";
import VueSplash from "vue-splash";

const app = createApp(App);

app.use(VueSplash);
app.use(VueSweetalert2);
app.use(router);
app.mount("#app");
