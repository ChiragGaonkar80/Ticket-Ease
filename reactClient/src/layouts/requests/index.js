import Grid from "@mui/material/Grid";

import MDBox from "components/MDBox";

import DashboardLayout from "examples/LayoutContainers/DashboardLayout";
import DashboardNavbar from "examples/Navbars/DashboardNavbar";
import ReportsBarChart from "examples/Charts/BarCharts/ReportsBarChart";
import ReportsLineChart from "examples/Charts/LineCharts/ReportsLineChart";
import ComplexStatisticsCard from "examples/Cards/StatisticsCards/ComplexStatisticsCard";

// Data
import reportsBarChartData from "layouts/dashboard/data/reportsBarChartData";
import reportsLineChartData from "layouts/dashboard/data/reportsLineChartData";

function Requests() {
  const requests = [
    {
      id: 12345,
      status: "Approved",
      employee: "Amardeep",
    },
    {
      id: 12346,
      status: "In-Progress",
      employee: "Chirag",
    },
    {
      id: 12347,
      status: "Open",
      employee: "Lakshita",
    },
    {
      id: 12345,
      status: "Approved",
      employee: "Amardeep",
    },
    {
      id: 12346,
      status: "In-Progress",
      employee: "Chirag",
    },
    {
      id: 12347,
      status: "Open",
      employee: "Lakshita",
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
                  color="success"
                  icon="store"
                  title={req.status}
                  count={req.id}
                  percentage={{
                    color: "success",
                    // amount: "+55%",
                    label: req.employee,
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
