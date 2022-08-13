<template>
  <NavBar />
  <router-view />
</template>

<script>
import { defineAsyncComponent } from "vue";
export default {
  name: "EntityLayout",
  components: {
    NavBar: defineAsyncComponent(() => import("@/components/NavBar")),
  },
};
</script>

<style></style>
