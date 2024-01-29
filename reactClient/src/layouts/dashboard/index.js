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

import Box from "@mui/material/Box";
import Card from "@mui/material/Card";
import CardActions from "@mui/material/CardActions";
import CardContent from "@mui/material/CardContent";
import Button from "@mui/material/Button";
import Typography from "@mui/material/Typography";

import { useState } from "react";

// Dashboard components

function Dashboard() {
  const [activeDept, setActiveDept] = useState(1);

  const tasks = [
    {
      id: 1,
      dept: "Admin and Security Staff",
      icon: "weekend",
      color: "dark",
      count: 10,
      features: [
        {
          id: 1,
          feature: "Electrical",
          description: "Manage electrical equipment and issues.",
        },
        {
          id: 2,
          feature: "Travel Request",
          description: "Request and manage travel arrangements.",
        },
        {
          id: 3,
          feature: "Pantry Service",
          description: "Handle pantry and catering service requests.",
        },
        {
          id: 4,
          feature: "Raise Query",
          description: "Submit and address general queries.",
        },
        {
          id: 5,
          feature: "Give Feedback",
          description: "Provide feedback on services and experiences.",
        },
      ],
    },

    {
      id: 2,
      dept: "Human Resources and Payroll",
      icon: "leaderboard",
      color: "success",
      count: 5,
      features: [
        {
          id: 1,
          feature: "Salary Related Queries",
          description: "Address salary-related queries and concerns.",
        },
        {
          id: 2,
          feature: "Leaves and Absences",
          description: "Manage leave requests and absences.",
        },
        {
          id: 3,
          feature: "Update Profile and Skills",
          description: "Update employee profiles and skills.",
        },
        {
          id: 4,
          feature: "Mediclaim",
          description: "Handle medical insurance-related matters.",
        },
        {
          id: 5,
          feature: "Complaints",
          description: "Report and address HR-related complaints.",
        },
        {
          id: 6,
          feature: "Raise Query",
          description: "Submit and address general queries.",
        },
        {
          id: 7,
          feature: "Give Feedback",
          description: "Provide feedback on services and experiences.",
        },
      ],
    },

    {
      id: 3,
      dept: "Information Technology",
      icon: "store",
      color: "primary",
      count: 8,
      features: [
        {
          id: 1,
          feature: "Gen AI Tool",
          description: "Assistance with general IT tools.",
        },
        {
          id: 2,
          feature: "Hardware Request",
          description: "Request and manage hardware resources.",
        },
        {
          id: 3,
          feature: "Software Installation / Removal",
          description: "Install or remove software applications.",
        },
        {
          id: 4,
          feature: "Raise Query",
          description: "Submit and address general queries.",
        },
        {
          id: 5,
          feature: "Give Feedback",
          description: "Provide feedback on services and experiences.",
        },
      ],
    },
    {
      id: 4,
      dept: "Learning and Development",
      icon: "person_add",
      color: "warning",
      count: 15,
      features: [
        {
          id: 1,
          feature: "Training Request / Assistance",
          description: "Seek assistance for training-related matters.",
        },
        {
          id: 2,
          feature: "Course Enrollment",
          description: "Enroll in various courses and programs.",
        },
        {
          id: 3,
          feature: "Certification Assistance",
          description: "Get support for certification processes.",
        },
        {
          id: 4,
          feature: "Raise Query",
          description: "Submit and address general queries.",
        },
        {
          id: 5,
          feature: "Give Feedback",
          description: "Provide feedback on services and experiences.",
        },
      ],
    },
  ];

  const bull = (
    <Box component="span" sx={{ display: "inline-block", mx: "2px", transform: "scale(0.8)" }}>
      •
    </Box>
  );

  return (
    <DashboardLayout>
      <DashboardNavbar />
      <MDBox py={3}>
        <Grid container spacing={3}>
          {tasks.map((item, key) => {
            console.log("item==>>", item);
            return (
              <Grid item xs={12} md={6} lg={3} key={item.id} onClick={() => setActiveDept(item.id)}>
                <MDBox mb={1.5}>
                  <ComplexStatisticsCard
                    color={item.color}
                    icon={item.icon}
                    title={item.dept}
                    // count={281}
                    percentage={{
                      color: "success",
                      amount: item.count,
                      label: "Total tickets raised",
                    }}
                  />
                </MDBox>
              </Grid>
            );
          })}

          {/* <Grid item xs={12} md={6} lg={3}>
            <MDBox mb={1.5}>
              <ComplexStatisticsCard
                color="dark"
                icon="weekend"
                title="Bookings"
                count={281}
                percentage={{
                  color: "success",
                  amount: "+55%",
                  label: "than lask week",
                }}
              />
            </MDBox>
          </Grid>
          <Grid item xs={12} md={6} lg={3}>
            <MDBox mb={1.5}>
              <ComplexStatisticsCard
                icon="leaderboard"
                title="Today's Users"
                count="2,300"
                percentage={{
                  color: "success",
                  amount: "+3%",
                  label: "than last month",
                }}
              />
            </MDBox>
          </Grid>
          <Grid item xs={12} md={6} lg={3}>
            <MDBox mb={1.5}>
              <ComplexStatisticsCard
                color="success"
                icon="store"
                title="Revenue"
                count="34k"
                percentage={{
                  color: "success",
                  amount: "+1%",
                  label: "than yesterday",
                }}
              />
            </MDBox>
          </Grid>
          <Grid item xs={12} md={6} lg={3}>
            <MDBox mb={1.5}>
              <ComplexStatisticsCard
                color="primary"
                icon="person_add"
                title="Followers"
                count="+91"
                percentage={{
                  color: "success",
                  amount: "",
                  label: "Just updated",
                }}
              />
            </MDBox>
          </Grid> */}
        </Grid>

        <MDBox mt={4.5}>
          <Grid container spacing={3}>
            {tasks[activeDept - 1].features.map((item) => {
              return (
                <Grid item xs={12} md={6} lg={4} key={item.id}>
                  <MDBox mb={3}>
                    <Card sx={{ minWidth: 275 }}>
                      <CardContent>
                        {/* <Typography sx={{ fontSize: 14 }} color="text.secondary" gutterBottom>
                          Word of the Day
                        </Typography> */}
                        <Typography variant="h5" component="div">
                          {item.feature}
                        </Typography>
                        {/* <Typography sx={{ mb: 1.5 }} color="text.secondary">
                          adjective
                        </Typography> */}
                        <Typography variant="body2">{item.description}</Typography>
                      </CardContent>
                      <CardActions>
                        <Button size="small">Raise Request</Button>
                      </CardActions>
                    </Card>
                  </MDBox>
                </Grid>
              );
            })}

            {/* <Grid item xs={12} md={6} lg={4}>
              <MDBox mb={3}>
                <ReportsBarChart
                  color="info"
                  title="website views"
                  description="Last Campaign Performance"
                  date="campaign sent 2 days ago"
                  chart={reportsBarChartData}
                />
              </MDBox>
            </Grid>
            <Grid item xs={12} md={6} lg={4}>
              <MDBox mb={3}>
                <ReportsLineChart
                  color="success"
                  title="daily sales"
                  description={
                    <>
                      (<strong>+15%</strong>) increase in today sales.
                    </>
                  }
                  date="updated 4 min ago"
                  chart={sales}
                />
              </MDBox>
            </Grid>
            <Grid item xs={12} md={6} lg={4}>
              <MDBox mb={3}>
                <ReportsLineChart
                  color="dark"
                  title="completed tasks"
                  description="Last Campaign Performance"
                  date="just updated"
                  chart={tasks}
                />
              </MDBox>
            </Grid> */}
          </Grid>
        </MDBox>
        {/* <MDBox>
          <Grid container spacing={3}>
            <Grid item xs={12} md={6} lg={8}>
              <Projects />
            </Grid>
            <Grid item xs={12} md={6} lg={4}>
              <OrdersOverview />
            </Grid>
          </Grid>
        </MDBox> */}
      </MDBox>
      {/* <Footer />   */}
    </DashboardLayout>
  );
}

export default Dashboard;
