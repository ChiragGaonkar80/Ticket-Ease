/* eslint-disable react/prop-types */
/* eslint-disable react/function-component-definition */
/**
=========================================================
* Material Dashboard 2 React - v2.2.0
=========================================================

* Product Page: https://www.creative-tim.com/product/material-dashboard-react
* Copyright 2023 Creative Tim (https://www.creative-tim.com)

Coded by www.creative-tim.com

 =========================================================

* The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
*/

// Material Dashboard 2 React components
import MDBox from "components/MDBox";
import MDTypography from "components/MDTypography";
import MDAvatar from "components/MDAvatar";
import MDBadge from "components/MDBadge";

// Images
import team2 from "assets/images/team-2.jpg";
import team3 from "assets/images/team-3.jpg";
import team4 from "assets/images/team-4.jpg";

export default function data() {
  const Author = ({ image, name, email }) => (
    <MDBox display="flex" alignItems="center" lineHeight={1}>
      <MDBox ml={2} lineHeight={1}>
        <MDTypography display="block" variant="button" fontWeight="medium">
          {name}
        </MDTypography>
        <MDTypography variant="caption">{email}</MDTypography>
      </MDBox>
    </MDBox>
  );

  const Manager = ({ image, name, email }) => (
    <MDBox display="flex" alignItems="center" lineHeight={1}>
      <MDBox ml={2} lineHeight={1}>
        <MDTypography display="block" variant="button" fontWeight="medium">
          {name}
        </MDTypography>
        <MDTypography variant="caption">{email}</MDTypography>
      </MDBox>
    </MDBox>
  );

  const CreatedDate = ({ date, time }) => (
    <MDBox display="flex" alignItems="center" lineHeight={1}>
      <MDBox ml={2} lineHeight={1}>
        <MDTypography display="block" variant="button" fontWeight="medium">
          {date}
        </MDTypography>
        <MDTypography variant="caption">{time}</MDTypography>
      </MDBox>
    </MDBox>
  );

  const Job = ({ title, description }) => (
    <MDBox lineHeight={1} textAlign="left">
      <MDTypography display="block" variant="caption" color="text" fontWeight="medium">
        {title}
      </MDTypography>
      <MDTypography variant="caption">{description}</MDTypography>
    </MDBox>
  );

  return {
    columns: [
      { Header: "Ticket Id", accessor: "ticketId", align: "left" },
      { Header: "Name", accessor: "name", align: "center" },
      { Header: "Manager", accessor: "managerName", align: "center" },
      { Header: "Status", accessor: "status", align: "center" },
      { Header: "Date/Time", accessor: "dateAndTime", align: "center" },
      { Header: "Action", accessor: "action", align: "center" },
    ],

    rows: [
      {
        ticketId: <MDTypography>SR7892</MDTypography>,
        name: <Author image={team3} name="Chirag Gaonkar" email="chirag@persistent.com" />,
        managerName: <Manager image={team3} name="Gautam Wagh" email="gautam@persistent.com" />,
        status: (
          <MDBox ml={-1}>
            <MDBadge badgeContent="Pending" color="dark" variant="gradient" size="sm" />
          </MDBox>
        ),
        dateAndTime: <CreatedDate date={"12/09/2023"} time={"09:00 AM"} />,
        action: (
          <MDTypography component="a" href="#" variant="caption" color="text" fontWeight="medium">
            Edit
          </MDTypography>
        ),
      },
      {
        ticketId: <MDTypography>SR7842</MDTypography>,
        name: <Author image={team3} name="Shreyas Naik" email="shreyas@persistent.com" />,
        managerName: <Manager image={team3} name="Gautam Wagh" email="gautam@persistent.com" />,
        status: (
          <MDBox ml={-1}>
            <MDBadge badgeContent="Approved" color="success" variant="gradient" size="sm" />
          </MDBox>
        ),
        dateAndTime: <CreatedDate date={"12/09/2023"} time={"09:00 AM"} />,
        action: (
          <MDTypography component="a" href="#" variant="caption" color="text" fontWeight="medium">
            Edit
          </MDTypography>
        ),
      },
      {
        ticketId: <MDTypography>SR7892</MDTypography>,
        name: <Author image={team3} name="Lakshita Werulkar" email="lakshita@persistent.com" />,
        managerName: <Manager image={team3} name="Hemang Patel" email="hemu@persistent.com" />,
        status: (
          <MDBox ml={-1}>
            <MDBadge badgeContent="On Hold" color="warning" variant="gradient" size="sm" />
          </MDBox>
        ),
        dateAndTime: <CreatedDate date={"14/09/2023"} time={"09:40 AM"} />,
        action: (
          <MDTypography component="a" href="#" variant="caption" color="text" fontWeight="medium">
            Edit
          </MDTypography>
        ),
      },
      {
        ticketId: <MDTypography>SR7892</MDTypography>,
        name: <Author image={team3} name="Ritwik Bare" email="ritwik@persistent.com" />,
        managerName: (
          <Manager image={team3} name="Sujata Chowdhary" email="sujata@persistent.com" />
        ),
        status: (
          <MDBox ml={-1}>
            <MDBadge badgeContent="Pending" color="dark" variant="gradient" size="sm" />
          </MDBox>
        ),
        dateAndTime: <CreatedDate date={"17/09/2023"} time={"09:37 AM"} />,
        action: (
          <MDTypography component="a" href="#" variant="caption" color="text" fontWeight="medium">
            Edit
          </MDTypography>
        ),
      },
      {
        ticketId: <MDTypography>SR7892</MDTypography>,
        name: (
          <Author image={team3} name="Sharvani Parbhugaonkar" email="sharvani@persistent.com" />
        ),
        managerName: <Manager image={team3} name="Muskan Ladiya" email="muskan@persistent.com" />,
        status: (
          <MDBox ml={-1}>
            <MDBadge badgeContent="Approved" color="success" variant="gradient" size="sm" />
          </MDBox>
        ),
        dateAndTime: <CreatedDate date={"12/09/2023"} time={"09:00 AM"} />,
        action: (
          <MDTypography component="a" href="#" variant="caption" color="text" fontWeight="medium">
            Edit
          </MDTypography>
        ),
      },
    ],
  };
}
