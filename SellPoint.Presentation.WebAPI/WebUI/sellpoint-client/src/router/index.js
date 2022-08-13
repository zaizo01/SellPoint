import { createRouter, createWebHistory } from "vue-router";
import Home from "../views/Home.vue";
import authRouter from "../Modules/Auth/router";
import entitiesRouter from "../Modules/Entities/router";

const routes = [
  {
    path: "/",
    name: "Home",
    component: Home,
  },
  {
    path: "/about",
    name: "About",
    component: () =>
      import(/* webpackChunkName: "about" */ "../views/About.vue"),
  },
  {
    path: "/auth",
    ...authRouter,
  },
  {
    path: "/entidades",
    ...entitiesRouter,
  },
];

const router = createRouter({
  history: createWebHistory(process.env.BASE_URL),
  routes,
});

export default router;
