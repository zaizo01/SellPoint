export default {
  name: "entities",
  component: () =>
    import(/* webpackChunkName: "entities" */ "../layouts/EntityLayout.vue"),
  children: [
    {
      path: "",
      name: "entities-pages",
      component: () =>
        import(
          /* webpackChunkName: "entities-pages" */ "../views/EntitiesListPages.vue"
        ),
    },
    {
      path: "Create",
      name: "entities-create",
      component: import(
        /* webpackChunkName: "entities-create" */ "../views/EntitiesCreateOrEdit.vue"
      ),
    },
    {
      path: "Show/:id",
      name: "entities-show",
      component: import(
        /* webpackChunkName: "entities-create" */ "../views/EntitiesCreateOrEdit.vue"
      ),
    },
    {
      path: "Edit/:id",
      name: "entities-edit",
      component: import(
        /* webpackChunkName: "entities-edit" */ "../views/EntitiesCreateOrEdit.vue"
      ),
    },
  ],
};
