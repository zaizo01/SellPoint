<template>
  <div>
    home
    <!-- <vue-splash
      :show="true"
      :logo="logo"
      title="Your Magnificent App Name"
      color="#00bfa5"
      :size="300"
      :fixed="true"
    /> -->
  </div>
</template>

<script>
import YourLogo from "../assets/logo.png";

export default {
  name: "SplashScreen",
  computed: {
    logo() {
      return YourLogo;
    },
  },
};
</script>
