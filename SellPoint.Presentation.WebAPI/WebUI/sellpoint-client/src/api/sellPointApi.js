import axios from "axios";

const sellPoint = axios.create({
  baseURL: "https://localhost:44381/api/Entidades/",
});

export default sellPoint;
