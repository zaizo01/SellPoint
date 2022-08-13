export default {
  name: "auth",
  component: () =>
    import(/* webpackChunkName: "authLayout" */ "../layouts/AuthLayout.vue"),
  children: [
    {
      path: "login",
      name: "login",
      component: () =>
        import(/* webpackChunkName: "Login" */ "../views/Login.vue"),
    },
  ],
};
