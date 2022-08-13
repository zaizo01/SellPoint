<template>
  <div>
    <h3 class="mx-5 mt-3" v-if="isCreateAction">Crear Entidad</h3>
    <h3 class="mx-5 mt-3" v-if="isShowAction">Consulta de Entidad</h3>
    <h3 class="mx-5 mt-3" v-if="isEditAction">Editar Entidad</h3>
  </div>
  <div class="row border border-2 rounded shadow mx-5 my-3 p-4">
    <div class="col-md-6">
      <label class="form-label"
        >Direccion <span class="text-danger">*</span></label
      >
      <input
        type="text"
        class="form-control"
        v-model="entity.direccion"
        :disabled="isShowAction"
      />
    </div>
    <div class="col-md-6">
      <label class="form-label"
        >Localidad <span class="text-danger">*</span></label
      >
      <input
        type="text"
        class="form-control"
        v-model="entity.localidad"
        :disabled="isShowAction"
      />
    </div>
    <div class="col-md-12">
      <label class="form-label"
        >Descripcion <span class="text-danger">*</span></label
      >
      <input
        type="text"
        class="form-control"
        v-model="entity.descripcion"
        :disabled="isShowAction"
      />
    </div>
    <div class="col-md-4">
      <label class="form-label"
        >Tipo de Entidad <span class="text-danger">*</span></label
      >
      <select
        class="form-select"
        v-model="entity.tipoEntidad"
        :disabled="isShowAction"
      >
        <option value="Física">Física</option>
        <option value="Jurídica">Jurídica</option>
      </select>
    </div>
    <div class="col-md-4">
      <label class="form-label"
        >Tipo de Documento <span class="text-danger">*</span></label
      >
      <select
        class="form-select"
        v-model="entity.tipoDocumento"
        :disabled="isShowAction"
      >
        <option value="RNC">RNC</option>
        <option value="Cédula">Cédula</option>
        <option value="Pasaporte">Pasaporte</option>
      </select>
    </div>
    <div class="col-md-4">
      <label class="form-label"
        >Numero de Documento <span class="text-danger">*</span></label
      >
      <input
        v-if="typeMask == 'C'"
        type="text"
        class="form-control"
        v-mask="'000-0000000-0'"
        v-model="entity.numeroDocumento"
        :disabled="isShowAction"
      />
       <input
        v-else-if="typeMask == 'R'"
        type="text"
        class="form-control"
        v-mask="'000-00000-0'"
        v-model="entity.numeroDocumento"
        :disabled="isShowAction"
      />
       <input
        v-else
        type="text"
        class="form-control"
        v-mask="'000000000'"
        v-model="entity.numeroDocumento"
        :disabled="isShowAction"
      />
    </div>
    <div class="col-md-4">
      <label class="form-label"
        >Telefono <span class="text-danger">*</span></label
      >
      <input
        type="text"
        class="form-control"
        v-mask="'000-000-0000'"
        v-model="entity.telefonos"
        :disabled="isShowAction"
      />
    </div>
    <div class="col-md-4">
      <label class="form-label">Codigo Postal</label>
      <input
        type="text"
        class="form-control"
        v-model="entity.codigoPostal"
        :disabled="isShowAction"
      />
    </div>
    <div class="col-md-4">
      <label class="form-label">Coordenadas GPS</label>
      <input
        type="text"
        class="form-control"
        v-model="entity.coordenadasGPS"
        :disabled="isShowAction"
      />
    </div>
    <div class="col-md-4">
      <label class="form-label">Limite de Credito <span class="text-danger">*</span></label>
      <input
        type="text"
        class="form-control"
        v-model="entity.limiteCredito"
        :disabled="isShowAction"
      />
    </div>
    <div class="col-md-4">
      <label class="form-label"
        >Nombre de Usuario <span class="text-danger">*</span></label
      >
      <input
        type="text"
        class="form-control"
        v-model="entity.userNameEntidad"
        :disabled="isShowAction"
      />
    </div>
    <div class="col-md-4">
      <label class="form-label"
        >Contraseña de Usuario <span class="text-danger">*</span></label
      >
      <input
        type="password"
        class="form-control"
        v-model="entity.passworEntidad"
        :disabled="isShowAction"
      />
    </div>
    <div class="col-md-4">
      <label class="form-label"
        >Rol del Usuario <span class="text-danger">*</span></label
      >
      <select
        class="form-select"
        v-model="entity.rolUserEntidad"
        :disabled="isShowAction"
      >
        <option value="Admin">Admin</option>
        <option value="Supervisor">Supervisor</option>
        <option value="User">User</option>
      </select>
    </div>
    <div class="col-md-4">
      <label class="form-label"
        >Estado <span class="text-danger">*</span></label
      >
      <select
        class="form-select"
        v-model="entity.status"
        :disabled="isShowAction"
      >
        <option value="Activa">Activa</option>
        <option value="Inactiva">Inactiva</option>
      </select>
    </div>
    <div class="col-md-6">
      <label class="form-label">URL Pagina Web </label>
      <input
        type="text"
        class="form-control"
        v-model="entity.urlPaginaWeb"
        :disabled="isShowAction"
      />
    </div>
    <div class="col-md-6">
      <label class="form-label">URL Facebook</label>
      <input
        type="text"
        class="form-control"
        v-model="entity.urlFacebook"
        :disabled="isShowAction"
      />
    </div>
    <div class="col-md-6">
      <label class="form-label">URL Instagram</label>
      <input
        type="text"
        class="form-control"
        v-model="entity.urlInstagram"
        :disabled="isShowAction"
      />
    </div>
    <div class="col-md-6">
      <label class="form-label">URL Twitter</label>
      <input
        type="text"
        class="form-control"
        v-model="entity.urlTwitter"
        :disabled="isShowAction"
      />
    </div>
    <div class="col-md-6">
      <label class="form-label">URL TikTok</label>
      <input
        type="text"
        class="form-control"
        v-model="entity.urlTiktok"
        :disabled="isShowAction"
      />
    </div>
    <div class="col-md-12">
      <label class="form-label">Comentario</label>
      <textarea
        class="form-control"
        rows="3"
        v-model="entity.comentario"
        :disabled="isShowAction"
      ></textarea>
    </div>
    <div class="col-md-3" style="margin-top: 33px" v-if="isCreateAction">
      <button
        class="btn btn-primary form-control"
        @click="createEntity()"
        :disabled="isShowAction"
      >
        Guardar
      </button>
    </div>
    <div class="col-md-3" style="margin-top: 33px" v-if="isEditAction">
      <button
        class="btn btn-primary form-control"
        @click="editEntity()"
        :disabled="isShowAction"
      >
        Guardar Cambios
      </button>
    </div>
  </div>
</template>

<script>
import sellPointApi from "@/api/sellPointApi";
export default {
  name: "EntitesCreateOrEdit",
  data() {
    return {
      errorList: [],
      entity: {
        descripcion: null,
        direccion: null,
        localidad: null,
        tipoEntidad: null,
        tipoDocumento: 'Cédula',
        numeroDocumento: 0,
        telefonos: null,
        urlPaginaWeb: null,
        urlFacebook: null,
        urlInstagram: null,
        urlTwitter: null,
        urlTiktok: null,
        codigoPostal: null,
        coordenadasGPS: null,
        limiteCredito: 0,
        userNameEntidad: null,
        passworEntidad: null,
        rolUserEntidad: null,
        comentario: null,
        status: null,
        noEliminable: true,
      },
    };
  },
  created() {
    if (this.isCreateAction == false) {
      this.getEntityById();
    }
  },
  computed: {
    typeMask(){
      if (this.entity.tipoDocumento == 'Cédula') {
        this.entity.numeroDocumento = 0;
        return 'C'
      }
      if (this.entity.tipoDocumento == 'RNC') {
        this.entity.numeroDocumento = 0;
        return 'R'
      }
      if (this.entity.tipoDocumento == 'Pasaporte') {
        this.entity.numeroDocumento = 0;
        return 'p'
      }
    },
    isCitizen(){
      return this.entity.tipoDocumento === 'Cédula' ? true : false;
    },
    isRNC(){
      return this.entity.tipoDocumento === 'RNC' ? true : false;
    },
    isPassport(){
      return this.entity.tipoDocumento === 'Pasaporte' ? true : false;
    },
    isShowAction() {
      return this.$route.query.action == "showRecords" ? true : false;
    },
    isEditAction() {
      return this.$route.query.action == "editRecord" ? true : false;
    },
    isCreateAction() {
      return this.$route.query.action == "createRecord" ? true : false;
    },
  },
  methods: {
    clearForm() {
      this.errorList = [];
      this.entity = {
        descripcion: null,
        direccion: null,
        localidad: null,
        tipoEntidad: null,
        tipoDocumento: null,
        numeroDocumento: 0,
        telefonos: null,
        urlPaginaWeb: null,
        urlFacebook: null,
        urlInstagram: null,
        urlTwitter: null,
        urlTiktok: null,
        codigoPostal: null,
        coordenadasGPS: null,
        limiteCredito: 0,
        userNameEntidad: null,
        passworEntidad: null,
        rolUserEntidad: null,
        comentario: null,
        status: null,
        noEliminable: true,
      };
    },
    async getEntityById() {
      let id = this.$route.params.id;
      let response = await sellPointApi
        .get(`/GetEntityById/${id}`)
        .then((resp) => {
          if (this.isShowAction || this.isEditAction) {
            console.log(resp.data);
            this.entity = resp.data;
            this.entity.numeroDocumento = resp.data.numeroDocumento;
          }
        })
        .catch((err) => {
          this.$swal.fire({
            icon: "error",
            title: "Oops...",
            text: err,
          });
        });
    },
    async createEntity() {
      this.errorList = [];
      let documentNumber = this.entity.numeroDocumento.replace(/-/gi, "");
      this.entity.numeroDocumento = documentNumber;
      parseInt(this.entity.numeroDocumento);
      let response = await sellPointApi
        .post("/CreateEntity", this.entity)
        .then((resp) => {
          if (resp.status == 200) {
            this.$swal({
              icon: "success",
              title: "Notificación",
              text: "La Entidad ha sigo guardada correctamente.",
            });
            this.clearForm();
          }
        })
        .catch((err) => {
          const response = err.response.data.errors;
          for (const property in response) {
            this.errorList.push(`${response[property]}`);
          }
          this.$swal.fire({
            icon: "error",
            title: "Oops...",
            html: `<ul>${this.errorList.map(
              (error) => "<li>" + error + "</li>"
            )}</ul>`,
          });
        });
    },
    async editEntity() {
      this.errorList = [];
      parseInt(this.entity.numeroDocumento);
      let response = await sellPointApi
        .put("/UpdateEntity", this.entity)
        .then((resp) => {
          console.log(resp);
          if (resp.status == 200) {
            this.$swal({
              icon: "success",
              title: "Notificación",
              text: "La Entidad ha sigo editada correctamente.",
            });
            this.clearForm();
          }
        })
        .catch((err) => {
          const response = err.response.data.errors;
          for (const property in response) {
            this.errorList.push(`${response[property]}`);
          }
          this.$swal.fire({
            icon: "error",
            title: "Oops...",
            html: `<ul>${this.errorList.map(
              (error) => "<li>" + error + "</li>"
            )}</ul>`,
          });
        });
    },
  },
};
</script>

<style scoped></style>
