import { Container } from "@mui/material";

export default function Categories({ categories }) {
  return (
    <>
      <Container
        className=" shadow-[0px_10px_1px_rgba(221,_221,_221,_1),_0_10px_20px_rgba(204,_204,_204,_1)] w-[600px]"
        sx={{
          display: "flex",
          flexDirection: "column",
          height: "700px",
        }}
      >
        <h1 className=" font-mono font-extrabold text-[32px] text-slate-700 text-center">
          Categories
        </h1>
        <div>
          {categories.map((value, index) => {
            return (
              <p key={index} value={index} className=" text-center p-2">
                {value}
              </p>
            );
          })}
        </div>
      </Container>
    </>
  );
}
