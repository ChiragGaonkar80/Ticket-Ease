import Grid from "@mui/material/Grid";

import MDBox from "components/MDBox";

import DashboardLayout from "examples/LayoutContainers/DashboardLayout";
import DashboardNavbar from "examples/Navbars/DashboardNavbar";
import ReportsBarChart from "examples/Charts/BarCharts/ReportsBarChart";
import ReportsLineChart from "examples/Charts/LineCharts/ReportsLineChart";
import ComplexStatisticsCard from "examples/Cards/StatisticsCards/ComplexStatisticsCard";

function Requests() {
  const requests = [
    {
      id: 12345,
      status: "Approved",
      employee: "Amardeep",
      icon: "done",
      color: "success",
    },
    {
      id: 12346,
      status: "In-Progress",
      employee: "Chirag",
      icon: "pending",
      color: "warning",
    },
    {
      id: 12347,
      status: "Open",
      employee: "Lakshita",
      icon: "add",
      color: "secondary",
    },
    {
      id: 12345,
      status: "Approved",
      employee: "Amardeep",
      icon: "done",
      color: "success",
    },
    {
      id: 12346,
      status: "In-Progress",
      employee: "Chirag",
      icon: "pending",
      color: "warning",
    },
    {
      id: 12347,
      status: "Open",
      employee: "Lakshita",
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
              <MDBox mb={1.5}>
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
    </DashboardLayout>
  );
}

export default Requests;
