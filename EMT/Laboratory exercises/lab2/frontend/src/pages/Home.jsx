import {
  Box,
  Button,
  Container,
  Pagination,
  PaginationItem,
} from "@mui/material";
import { useState, useEffect } from "react";
import { accommodationsService } from "../api/api";
import { Link } from "react-router-dom";

export default function Home() {
  const [page, setPage] = useState(1);
  const [itemsPerPage] = useState(5);
  const startIndex = (page - 1) * itemsPerPage;
  const labels = [
    "Name",
    "Category",
    "Number of rooms",
    "Host",
    "Rent / Edit / Delete",
  ];

  const [accommodations, setAccommodations] = useState();
  useEffect(() => {
    accommodationsService.getAccommodations().then((res) => {
      setAccommodations(
        res.data.filter((accommodation) => accommodation.reserved != true)
      );
    });
  }, []);

  const renderItem = (item) => (
    <div key={item.id} className=" flex just">
      <p className="w-[195px] ml-[80px] p-2">{item.name}</p>
      <p className="w-[195px] p-2">{item.category}</p>
      <p className="w-[195px] p-2">
        <p className=" ml-[50px]">{item.num0fRooms}</p>
      </p>
      <p className=" w-[195px]">
        <p className=" ml-5">{item.host.name + " " + item.host.surname} </p>
      </p>
      <div className="w-[195px] flex justify-center gap-2">
        <div className=" mt-[-5px]">
          <Button
            variant="contained"
            sx={{ height: "30px", width: "60px", backgroundColor: "#809bce" }}
            onClick={async () => {
              await accommodationsService.reserveAccommodation(item.id);
              setAccommodations(
                accommodations.filter(
                  (accommodation) => accommodation.id != item.id
                )
              );
            }}
          >
            Rent
          </Button>
        </div>
        <div className=" mt-[-5px]">
          <Button
            variant="contained"
            sx={{ height: "30px", width: "60px", backgroundColor: "#809bce" }}
          >
            <Link to={`/accommodations/edit/${item.id}`}>Edit</Link>
          </Button>
        </div>
        <div className=" mt-[-5px]">
          <Button
            variant="contained"
            sx={{ height: "30px", width: "60px", backgroundColor: "#809bce" }}
            onClick={async () => {
              await accommodationsService.deleteAccommodation(item.id);
              setAccommodations(
                accommodations.filter(
                  (accommodation) => accommodation.id != item.id
                )
              );
            }}
          >
            Delete
          </Button>
        </div>
      </div>
    </div>
  );

  return (
    <>
      <Container
        className=" shadow-[0px_10px_1px_rgba(221,_221,_221,_1),_0_10px_20px_rgba(204,_204,_204,_1)]"
        sx={{
          display: "flex",
          flexDirection: "column",
        }}
      >
        <div className=" flex justify-evenly mt-[60px]">
          {labels.map((value, index) => {
            return (
              <p
                key={index}
                className=" font-sens font-bol text-emerald-950 text-[20px]"
              >
                {value}
              </p>
            );
          })}
        </div>
        <Box
          sx={{
            display: "flex",
            flexDirection: "column",
            height: "600px",
            marginTop: "20px",
          }}
        >
          {accommodations
            ?.slice(startIndex, startIndex + itemsPerPage)
            .filter((accommodation) => accommodation.reserved != true)
            .map(renderItem)}
        </Box>
        <Box sx={{ display: "flex", justifyContent: "center" }}>
          <Pagination
            count={Math.ceil(accommodations?.length / itemsPerPage)}
            page={page}
            sx={{ color: "red" }}
            onChange={(e, newPage) => {
              setPage(newPage);
            }}
          />
        </Box>
      </Container>
    </>
  );
}
