import * as React from "react";
import Grid from "@mui/material/Grid";

import MDBox from "components/MDBox";

import DashboardLayout from "examples/LayoutContainers/DashboardLayout";
import DashboardNavbar from "examples/Navbars/DashboardNavbar";
import ComplexStatisticsCard from "examples/Cards/StatisticsCards/ComplexStatisticsCard";

import OrdersOverview from "layouts/dashboard/components/OrdersOverview";

import Modal from "@mui/material/Modal";

import Box from "@mui/material/Box";

const style = {
  position: "absolute",
  top: "50%",
  left: "50%",
  transform: "translate(-50%, -50%)",
  width: 400,
  bgcolor: "background.paper",
  border: "2px solid #000",
  boxShadow: 24,
  p: 4,
};

function Incidents() {
  const [open, setOpen] = React.useState(false);
  const handleOpen = () => setOpen(true);
  const handleClose = () => setOpen(false);

  const requests = [
    {
      id: 12345,
      status: "Approved",
      employee: "Shreyas",
      icon: "done",
      color: "success",
    },
    {
      id: 12346,
      status: "In-Progress",
      employee: "Muskan",
      icon: "pending",
      color: "warning",
    },
    {
      id: 12347,
      status: "Open",
      employee: "Sujata",
      icon: "add",
      color: "secondary",
    },
    {
      id: 12345,
      status: "Approved",
      employee: "Shreyas",
      icon: "done",
      color: "success",
    },
    {
      id: 12346,
      status: "In-Progress",
      employee: "Muskan",
      icon: "pending",
      color: "warning",
    },
    {
      id: 12347,
      status: "Open",
      employee: "Sujata",
      icon: "add",
      color: "secondary",
    },
    {
      id: 12348,
      status: "Cancelled",
      employee: "Sharvani",
      icon: "close",
      color: "primary",
    },
  ];

  return (
    <DashboardLayout>
      <DashboardNavbar />
      <MDBox py={3}>
        <Grid container spacing={3}>
          {requests.map((req, i) => (
            <Grid item xs={12} md={6} lg={3} key={i}>
              <MDBox mb={1.5} onClick={handleOpen}>
                <ComplexStatisticsCard
                  color={req.color}
                  icon={req.icon}
                  title={req.status}
                  count={"SR-" + req.id}
                  percentage={{
                    color: "success",
                    // amount: "+55%",
                    label: "Assigned - " + req.employee,
                  }}
                />
              </MDBox>
            </Grid>
          ))}
        </Grid>
      </MDBox>

      <Modal
        open={open}
        onClose={handleClose}
        aria-labelledby="modal-modal-title"
        aria-describedby="modal-modal-description"
      >
        <Box sx={style}>
          <OrdersOverview />
        </Box>
      </Modal>
    </DashboardLayout>
  );
}

export default Incidents;
