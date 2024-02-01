import axios from "axios";
// require("dotenv").config();

// console.log("REACT_APP_API_URL-->", process.env.REACT_APP_API_URL);

export default axios.create({
  baseURL: "https://localhost:7093/api/",

  // baseURL: "http://localhost:7722/api/",
});
