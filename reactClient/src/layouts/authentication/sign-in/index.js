import { useEffect, useState } from "react";

import Card from "@mui/material/Card";
import Switch from "@mui/material/Switch";

// Material Dashboard 2 React components
import MDBox from "components/MDBox";
import MDTypography from "components/MDTypography";
import MDInput from "components/MDInput";
import MDButton from "components/MDButton";

// Authentication layout components
import BasicLayout from "layouts/authentication/components/BasicLayout";

// Images
import bgImage from "assets/images/bg-sign-in-basic.png";
import axios from "axios";
import Api from "utils/Api";

function Basic() {
  const [rememberMe, setRememberMe] = useState(false);

  const handleSetRememberMe = () => setRememberMe(!rememberMe);

  const [email, setEmail] = useState("");

  const [password, setPassword] = useState("");

  const checkLogin = async () => {
    console.log(email);
    console.log(password);
    console.log(rememberMe);

    try {
      const res = await Api.get("/Employee/Login", {
        data: {
          email: email,
          password: password,
          isAdmin: rememberMe,
        },
      });

      console.log("res==>>", res);
    } catch (err) {
      console.log("err==>>", err);
    }
  };

  // useEffect(() => {
  //   axios
  //     .get(
  //       "https://localhost:7093/api/Employee/GetEmployeeByCredentials?email=siya%40gmail.com&password=siya123&isAdmin=false"
  //     )
  //     .then((res) => {
  //       console.log("res==>>", res.data);
  //     });
  // }, []);

  return (
    <BasicLayout image={bgImage}>
      <Card>
        <MDBox
          pt={4}
          pb={3}
          px={3}
          xl={6}
          style={{
            height: "100vh",
            alignItems: "center",
            display: "flex",
            justifyContent: "center",
          }}
        >
          <MDBox component="form" role="form">
            <MDBox
              display="flex"
              justifyContent="space-between"
              alignItems="center"
              pt={2}
              px={2}
              style={{ justifyContent: "center" }}
            >
              <MDTypography variant="h2" fontWeight="medium" textTransform="capitalize">
                Hello There!
              </MDTypography>
            </MDBox>
            <MDBox
              display="flex"
              justifyContent="space-between"
              alignItems="center"
              pt={2}
              px={2}
              style={{ justifyContent: "center" }}
            >
              <MDTypography variant="h6" fontWeight="medium" textTransform="capitalize">
                Welcome back, you almost forgot me
              </MDTypography>
            </MDBox>
            <MDBox
              display="flex"
              justifyContent="space-between"
              alignItems="center"
              pt={2}
              px={2}
              style={{ justifyContent: "center" }}
            >
              <MDTypography variant="h4" fontWeight="medium" textTransform="capitalize">
                SIGN IN
              </MDTypography>
            </MDBox>
            <MDBox mb={2}>
              <MDInput
                type="email"
                label="Email"
                fullWidth
                onChange={(e) => setEmail(e.target.value)}
              />
            </MDBox>
            <MDBox mb={2}>
              <MDInput
                type="password"
                label="Password"
                fullWidth
                onChange={(e) => setPassword(e.target.value)}
              />
            </MDBox>

            <MDBox display="flex" alignItems="center" ml={-1}>
              <Switch checked={rememberMe} onChange={handleSetRememberMe} />
              <MDTypography
                variant="button"
                fontWeight="regular"
                color="text"
                onClick={handleSetRememberMe}
                sx={{ cursor: "pointer", userSelect: "none", ml: -1 }}
              >
                &nbsp;&nbsp;Login as Administrator
              </MDTypography>
            </MDBox>
            <MDBox mt={4} mb={1}>
              <MDButton variant="gradient" color="secondary" fullWidth onClick={() => checkLogin()}>
                sign in
              </MDButton>
            </MDBox>
          </MDBox>
        </MDBox>
      </Card>
    </BasicLayout>
  );
}

export default Basic;
