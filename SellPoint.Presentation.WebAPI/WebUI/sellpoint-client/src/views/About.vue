<template>
  <NavBar />
  <div
    class="d-flex justify-content-center align-items-center w-100"
    style="height: 100vh"
  >
    <h3>Participantes</h3>
    <div class="card mx-3" style="width: 18rem">
      <div class="card-body">
        <h5 class="card-title">Cristopher Zaiz Ortega</h5>
        <h6 class="card-subtitle mb-2 text-muted">Software Developer</h6>
        <h3 class="card-text">2021-0949</h3>
      </div>
    </div>
    <div class="card" style="width: 18rem">
      <div class="card-body">
        <h5 class="card-title">Geronimo Guayara</h5>
        <h6 class="card-subtitle mb-2 text-muted">Software Developer</h6>
        <h3 class="card-text">2020-10314</h3>
      </div>
    </div>
  </div>
</template>

<script>
import { defineAsyncComponent } from "vue";
export default {
  name: "About",
  components: {
    NavBar: defineAsyncComponent(() => import("@/components/NavBar")),
  },
};
</script>

<style></style>
