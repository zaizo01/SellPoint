<template>
  <div class="d-flex justify-content-center align-items-center h-100">
    <div class="card border border-2">
      <div class="text-center mt-5">
        <h3>SellPoint Login</h3>
      </div>
      <div class="tab-content" id="pills-tabContent">
        <div
          class="tab-pane fade show active"
          id="pills-home"
          role="tabpanel"
          aria-labelledby="pills-home-tab"
        >
          <div class="form px-4 pt-4">
            <input
              type="text"
              class="form-control"
              placeholder="Email or Phone"
            />

            <input type="text" class="form-control" placeholder="Password" />
            <button class="btn btn-primary btn-block w-100" @click="login">
              Login
            </button>
          </div>
        </div>
        <div
          class="tab-pane fade"
          id="pills-profile"
          role="tabpanel"
          aria-labelledby="pills-profile-tab"
        >
          <div class="form px-4">
            <input type="text" class="form-control" placeholder="UserName" />

            <input type="text" class="form-control" placeholder="Email" />

            <input type="text" class="form-control" placeholder="Phone" />

            <input
              type="password"
              class="form-control"
              placeholder="Password"
            />

            <button class="btn btn-dark btn-block">Signup</button>
          </div>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
export default {
  name: "LoginForm",
  methods: {
    login() {
      console.log("login");
    },
  },
};
</script>

<style scoped>
body {
  background-color: #000;
}

.card {
  width: 400px;
  border: none;
}

.btr {
  border-top-right-radius: 5px !important;
}

.btl {
  border-top-left-radius: 5px !important;
}

.btn-dark {
  color: #fff;
  background-color: #0d6efd;
  border-color: #0d6efd;
}

.btn-dark:hover {
  color: #fff;
  background-color: #0d6efd;
  border-color: #0d6efd;
}

.nav-pills {
  display: table !important;
  width: 100%;
}

.nav-pills .nav-link {
  border-radius: 0px;
  border-bottom: 1px solid #0d6efd40;
}

.nav-item {
  display: table-cell;
  background: #0d6efd2e;
}

.form {
  padding: 10px;
  height: 300px;
}

.form input {
  margin-bottom: 12px;
  border-radius: 3px;
}

.form input:focus {
  box-shadow: none;
}

.form button {
  margin-top: 20px;
}
</style>
