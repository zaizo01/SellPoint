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
import sellPointApi from "@/api/sellPointApi";

export default {
  name: "SplashScreen",
  created() {
    this.getEntitiesRecords();
  },
  computed: {
    logo() {
      return YourLogo;
    },
  },
  methods: {
    async getEntitiesRecords() {
      let response = await sellPointApi
        .get("/GetAllEntities")
        .then((resp) => {
          // if (resp.data.length == 0) {
          //   this.$router.push({ name: "login" });
          // } else {
          //   this.$router.push({ name: "About" });
          // }
          console.log(resp.data);
        })
        .catch((err) => console.log(err));
    },
  },
};
</script>
