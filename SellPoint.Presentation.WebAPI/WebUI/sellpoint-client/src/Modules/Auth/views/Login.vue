<template>
  <FormLogin />
</template>

<script>
import { defineAsyncComponent } from "vue";
export default {
  name: "Login",
  components: {
    FormLogin: defineAsyncComponent(() =>
      import("../components/LoginForm.vue")
    ),
  },
};
</script>

<style></style>
