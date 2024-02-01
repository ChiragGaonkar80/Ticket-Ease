import * as React from "react";

import DashboardLayout from "examples/LayoutContainers/DashboardLayout";
import DashboardNavbar from "examples/Navbars/DashboardNavbar";

function Manager() {
  return (
    <DashboardLayout>
      <DashboardNavbar />
      Welcome
    </DashboardLayout>
  );
}

export default Manager;
