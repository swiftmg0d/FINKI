import { Suspense, useEffect, useState } from "react";
import Header from "./components/Header";
import Home from "./pages/Home";
import { Routes, Route } from "react-router-dom";
import { accommodationsService } from "./api/api";
import AccomodationForm from "./pages/AccomodationForm";
import Categories from "./pages/Categories";
function App() {
  const [categories, setCategories] = useState([]);
  useEffect(() => {
    accommodationsService.getAccommodationCategories().then((res) => {
      setCategories(res.data);
    });
  }, []);
  const [hosts, setHosts] = useState([]);
  useEffect(() => {
    accommodationsService.getHosts().then((res) => {
      setHosts(res.data);
    });
  }, []);

  return (
    <>
      <Suspense fallback={<h2>⏳ Loading...</h2>}>
        <Header />
        <Routes>
          <Route path="/" element={<Home />} />
          <Route path="/accommodations" element={<Home />} />
          <Route
            path="/accommodations/add"
            element={<AccomodationForm categories={categories} hosts={hosts} />}
          />
          AccomodationForm
          <Route
            path="/accommodations/edit/:id"
            element={<AccomodationForm categories={categories} hosts={hosts} />}
          />
          <Route
            path="/accommodations/categories"
            element={<Categories categories={categories} />}
          />
          <Route
            path="*"
            element={
              <div className=" flex justify-center font-mono font-bold">
                <h2>404 Not Found</h2>
              </div>
            }
          />
        </Routes>
      </Suspense>
    </>
  );
}

export default App;
