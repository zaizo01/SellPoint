<template>
  <div>
    <div class="d-flex w-100 justify-content-center pt-5">
      <img src="../assets/SellPointLogo.png" alt="SellPoint Logo" style="width:200px; height:200px">
    </div>
    <div id="loading-wrapper">
    <div id="loading-text">SellPoint <span style="font-weight:bold">v1.0</span> </div>
    <div id="loading-content"></div>
</div>
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
          if (resp.data.length == 0) {
            setTimeout(() => {
              this.$router.push({
                name: "entities-create",
                query: { action: "createRecord" },
              });
            }, 5000);
          } else {
            setTimeout(() => {
              this.$router.push({ name: "login" });
            }, 5000);
          }
        })
        .catch((err) => console.log(err));
    },
  },
};
</script>

<style scoped>
  #loading-wrapper {
    position: fixed;
    width: 100%;
    height: 100%;
    left: 0;
    top: 0;
  }

  #loading-text {
    display: block;
    position: absolute;
    top: 47%;
    left: 50%;
    color: rgb(20, 121, 60);
    width: 100px;
    height: 30px;
    margin: -7px 0 0 -45px;
    text-align: center;
    font-family: 'PT Sans Narrow', sans-serif;
    font-size: 20px;
  }

  #loading-content {
    display: block;
    position: relative;
    left: 50%;
    top: 50%;
    width: 170px;
    height: 170px;
    margin: -85px 0 0 -85px;
    border: 3px solid #F00;
  }

  #loading-content {
    border: 3px solid transparent;
    border-top-color: #2c3e50;
    border-bottom-color: #2c3e50;
    border-radius: 50%;
    -webkit-animation: loader 2s linear infinite;
    -moz-animation: loader 2s linear infinite;
    -o-animation: loader 2s linear infinite;
    animation: loader 2s linear infinite;
  }

  @keyframes loader {
    0% {
      -webkit-transform: rotate(0deg);
      -ms-transform: rotate(0deg);
      transform: rotate(0deg);
    }

    100% {
      -webkit-transform: rotate(360deg);
      -ms-transform: rotate(360deg);
      transform: rotate(360deg);
    }
  }
</style>
