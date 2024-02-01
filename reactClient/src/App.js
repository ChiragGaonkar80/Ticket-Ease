import { useState, useEffect, useMemo } from "react";

// react-router components
import { Routes, Route, Navigate, useLocation } from "react-router-dom";

// @mui material components
import { ThemeProvider } from "@mui/material/styles";
import CssBaseline from "@mui/material/CssBaseline";

// Material Dashboard 2 React components
import MDBox from "components/MDBox";

// Material Dashboard 2 React example components
import Sidenav from "examples/Sidenav";
import Configurator from "examples/Configurator";

// Material Dashboard 2 React themes
import theme from "assets/theme";

import themeDark from "assets/theme-dark";
// Material Dashboard 2 React routes
import routes from "routes";
import adminRoutes from "adminRoutes";

// Material Dashboard 2 React contexts
import { useMaterialUIController, setMiniSidenav, setOpenConfigurator } from "context";

// Images
import brandWhite from "assets/images/TE.png";
import Api from "utils/Api";
import Basic from "layouts/authentication/sign-in";

export default function App() {
  const [controller, dispatch] = useMaterialUIController();
  const { miniSidenav, direction, layout, sidenavColor, darkMode } = controller;
  const [onMouseEnter, setOnMouseEnter] = useState(false);
  const { pathname } = useLocation();

  const [admin, setAdmin] = useState(true);
  const [signed, isSigned] = useState(true);

  const handleOnMouseEnter = () => {
    if (miniSidenav && !onMouseEnter) {
      setMiniSidenav(dispatch, false);
      setOnMouseEnter(true);
    }
  };

  const handleOnMouseLeave = () => {
    if (onMouseEnter) {
      setMiniSidenav(dispatch, true);
      setOnMouseEnter(false);
    }
  };

  useEffect(() => {
    document.body.setAttribute("dir", direction);
  }, [direction]);

  // useEffect(async () => {
  // const token = await window.sessionStorage("authtoken");
  // console.log("token==>>", token);
  // if (token !== null) setAdmin(true);
  // }, []);

  useEffect(() => {
    async function fetchData() {
      const token = await window.sessionStorage.getItem("authtoken");
      console.log("token==>>", token);
      if (token !== null) setAdmin(true);
    }
    fetchData();

    // Api.get("BU/GetAll").then((res) => {
    //   console.log("res==>>", res);
    // });
  }, []);

  useEffect(() => {
    document.documentElement.scrollTop = 0;
    document.scrollingElement.scrollTop = 0;
  }, [pathname]);

  const getRoutes = (allRoutes) =>
    allRoutes.map((route) => {
      if (route.collapse) {
        return getRoutes(route.collapse);
      }

      if (route.route) {
        return <Route exact path={route.route} element={route.component} key={route.key} />;
      }

      return null;
    });
  return (
    <ThemeProvider theme={theme}>
      <CssBaseline />
      <Routes>
        <Route path="/authentication/sign-in" element={<Basic />} />
      </Routes>
      {signed && admin == false && (
        <Sidenav
          color={sidenavColor}
          brand={brandWhite}
          brandName="Ticket Ease"
          routes={routes}
          onMouseEnter={handleOnMouseEnter}
          onMouseLeave={handleOnMouseLeave}
        />
      )}
      {signed && admin == true && (
        <Sidenav
          color={sidenavColor}
          brand={brandWhite}
          brandName="Ticket Ease"
          routes={adminRoutes}
          onMouseEnter={handleOnMouseEnter}
          onMouseLeave={handleOnMouseLeave}
        />
      )}
      {signed && admin == false && (
        <Routes>
          {getRoutes(routes)}
          <Route path="*" element={<Navigate to="/dashboard" />} />
        </Routes>
      )}

      {signed && admin == true && (
        <Routes>
          {getRoutes(adminRoutes)}
          <Route path="*" element={<Navigate to="/admin/dashboard" />} />
        </Routes>
      )}
    </ThemeProvider>
  );
}
