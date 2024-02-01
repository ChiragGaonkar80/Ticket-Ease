import Dashboard from "layouts/dashboard";

import Profile from "layouts/profile";

// @mui icons
import Icon from "@mui/material/Icon";
import Incidents from "layouts/admin/Incidents";
import Requests from "layouts/admin/Requests";
import Analytics from "layouts/admin/Analytics/Analytics";

const routes = [
  {
    type: "collapse",
    name: "Dashboard",
    key: "dashboard",
    icon: <Icon fontSize="small">dashboard</Icon>,
    route: "/admin/dashboard",
    component: <Analytics />,
  },

  {
    type: "collapse",
    name: "My Incidents",
    key: "myincidents",
    icon: <Icon fontSize="small">person</Icon>,
    route: "/admin/incidents",
    component: <Incidents />,
  },

  {
    type: "collapse",
    name: "My Requests",
    key: "myrequests",
    icon: <Icon fontSize="small">person</Icon>,
    route: "/admin/requests",
    component: <Requests />,
  },
  {
    type: "collapse",
    name: "Profile",
    key: "profile",
    icon: <Icon fontSize="small">person</Icon>,
    route: "/admin/profile",
    component: <Profile />,
  },

  //   {
  //     type: "collapse",
  //     name: "Sign Out",
  //     key: "sign-out",
  //     icon: <Icon fontSize="small">login</Icon>,
  //     route: "/authentication/sign-in",
  //     component: <SignIn />,
  //   },
];

export default routes;
