<template>
  <nav class="navbar navbar-expand-lg navbar-dark bg-dark">
    <div class="container-fluid">
      <a class="navbar-brand" href="#">SellPoint </a>
      <button
        class="navbar-toggler"
        type="button"
        data-bs-toggle="collapse"
        data-bs-target="#navbarScroll"
        aria-controls="navbarScroll"
        aria-expanded="false"
        aria-label="Toggle navigation"
      >
        <span class="navbar-toggler-icon"></span>
      </button>
      <div class="collapse navbar-collapse" id="navbarScroll">
        <div class="dropdown">
          <button
            class="btn btn-secondary dropdown-toggle"
            type="button"
            data-bs-toggle="dropdown"
            aria-expanded="false"
          >
            Archivos (Mantenimientos)
          </button>
          <ul
            class="dropdown-menu dropdown-menu-dark"
            aria-labelledby="dropdownMenuButton1"
          >
            <li>
              <router-link
                class="dropdown-item"
                :to="{ name: 'entities-pages' }"
                >Entidades</router-link
              >
            </li>
          </ul>
        </div>

        <div class="dropdown mx-3">
          <button
            class="btn btn-secondary dropdown-toggle"
            type="button"
            data-bs-toggle="dropdown"
            aria-expanded="false"
          >
            Sistema
          </button>
          <ul
            class="dropdown-menu dropdown-menu-dark"
            aria-labelledby="dropdownMenuButton1"
          >
            <li>
              <router-link class="dropdown-item" :to="{ name: 'About' }"
                >Acerca de...</router-link
              >
            </li>
            <li>
              <a class="dropdown-item" @click="login">Login</a>
            </li>
            <li>
              <a class="dropdown-item" @click="out">Salir</a>
            </li>
          </ul>
        </div>
        <div class="dropdown">
          <button
            class="btn btn-secondary dropdown-toggle"
            type="button"
            data-bs-toggle="dropdown"
            aria-expanded="false"
          >
            <i class="fa fa-user"></i> {{ user }}
          </button>
          <ul
            class="dropdown-menu dropdown-menu-dark"
            aria-labelledby="dropdownMenuButton1"
          >
            <li>
              <a class="dropdown-item"
                >Fecha actual: {{ dateTime(currentDate) }}</a
              >
            </li>
          </ul>
        </div>
      </div>
    </div>
  </nav>
</template>

<script>
import moment from "moment";
export default {
  name: "Navbar",
  data() {
    return {
      user: null,
      currentDate: new Date(),
    };
  },
  methods: {
    login() {
      localStorage.removeItem("User");
      this.$router.push({ name: "login" });
    },
    out() {
      localStorage.removeItem("User");
      this.$router.push({ name: "Home" });
    },
    dateTime(value) {
      return moment(value).format("YYYY-MM-DD HH:MM");
    },
  },
  created() {
    const user = localStorage.getItem("User");
    if (user !== null || user !== undefined) {
      this.user = user;
    }
  },
};
</script>

<style></style>
