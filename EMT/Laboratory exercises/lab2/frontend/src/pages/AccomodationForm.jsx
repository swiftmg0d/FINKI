import { Box, Container } from "@mui/material";
import {
  FormControl,
  InputLabel,
  Input,
  MenuItem,
  Select,
  NativeSelect,
} from "@mui/material";
import { useEffect, useState } from "react";
import { accommodationsService } from "../api/api";
import { Button } from "antd";
import { useNavigate, useParams, redirect } from "react-router-dom";

export default function AccomodationForm({ categories, hosts }) {
  const list = ["ROOM", "HOUSE", "FLAT", "APARTMENT", "HOTEL", "MOTEL"];
  const navigate = useNavigate();
  const [accommodation, setAccommodation] = useState({
    name: "",
    category: 1,
    num0fRooms: 0,
    host: 1,
  });
  const [updated, setUpdated] = useState(false);

  function handleSubmit(e) {
    const { name, category, num0fRooms, host } = accommodation;
    id != null
      ? accommodationsService.editAccommodation(
          id,
          name,
          category,
          num0fRooms,
          host
        )
      : accommodationsService.addAccommodation(
          name,
          category,
          num0fRooms,
          host
        );
    navigate("/accommodations");
  }
  const { id } = useParams();

  useEffect(() => {
    if (id) {
      accommodationsService.getAccommodation(id).then((res) => {
        const data = {
          name: res.data.name,
          category: list.indexOf(res.data.category),
          num0fRooms: res.data.num0fRooms,
          host: res.data.host.id,
        };
        setAccommodation(data);
      });
    }
  }, []);

  return (
    <>
      <Container
        className=" shadow-[0px_10px_1px_rgba(221,_221,_221,_1),_0_10px_20px_rgba(204,_204,_204,_1)] w-[600px]"
        sx={{
          display: "flex",
          justifyContent: "center",
          flexDirection: "column",
          height: "700px",
        }}
      >
        <Container
          sx={{ display: "flex", justifyContent: "center", marginTop: "-20px" }}
        >
          {id != null ? (
            <h1 className=" font-mono font-extrabold text-[32px] text-slate-700">
              Edit Accommodation
            </h1>
          ) : (
            <h1 className=" font-mono font-extrabold text-[32px] text-slate-700">
              Add Accommodation
            </h1>
          )}
        </Container>
        <Container
          sx={{
            display: "flex",
            flexDirection: "column",
            padding: "100px",
            marginTop: "-70px",
          }}
        >
          <Box
            sx={{ display: "flex", justifyContent: "center", padding: "20px" }}
          >
            <FormControl>
              <InputLabel htmlFor="my-input">
                Name of the accommodation
              </InputLabel>
              <Input
                id="my-input"
                aria-describedby="my-helper-text"
                className=" w-[240px]"
                value={accommodation.name}
                onChange={(e) => {
                  setAccommodation({
                    ...accommodation,
                    name: e.target.value,
                  });
                }}
              />
            </FormControl>
          </Box>
          <Box
            sx={{ display: "flex", justifyContent: "center", padding: "20px" }}
          >
            <FormControl>
              <InputLabel id="demo-simple-select-label">Category</InputLabel>
              <NativeSelect
                id="demo-simple-select"
                labelId="demo-simple-select-label"
                value={accommodation.category}
                onChange={(e) => {
                  setAccommodation({
                    ...accommodation,
                    category: e.target.value,
                  });
                }}
                inputProps={{
                  name: "category",
                  id: "uncontrolled-native",
                }}
              >
                {categories.map((value, index) => {
                  return (
                    <option key={index} value={index}>
                      {value}
                    </option>
                  );
                })}
              </NativeSelect>
            </FormControl>
          </Box>
          <Box
            sx={{ display: "flex", justifyContent: "center", padding: "20px" }}
          >
            <FormControl>
              <InputLabel htmlFor="my-input">Number of rooms</InputLabel>
              <Input
                id="my-input"
                aria-describedby="my-helper-text"
                className=" w-[240px]"
                type="number"
                value={accommodation.num0fRooms}
                onChange={(e) => {
                  setAccommodation({
                    ...accommodation,
                    num0fRooms: parseInt(e.target.value),
                  });
                }}
              />
            </FormControl>
          </Box>

          <Box
            sx={{ display: "flex", justifyContent: "center", padding: "20px" }}
          >
            <FormControl>
              <InputLabel variant="standard" htmlFor="uncontrolled-native">
                Host
              </InputLabel>
              <NativeSelect
                defaultValue={accommodation.host}
                value={accommodation.host}
                inputProps={{
                  name: "host",
                  id: "uncontrolled-native",
                }}
              >
                {hosts.map((value, index) => {
                  return (
                    <option key={index} value={value.id}>
                      {value.name + " " + value.surname}
                    </option>
                  );
                })}
              </NativeSelect>
            </FormControl>
          </Box>
        </Container>
        <Box
          sx={{ display: "flex", justifyContent: "center", padding: "20px" }}
        >
          <Button
            variant="contained"
            sx={{ height: "30px", width: "60px", backgroundColor: "#809bce" }}
            onClick={(e) => handleSubmit(e)}
          >
            Submit
          </Button>
        </Box>
      </Container>
    </>
  );
}
