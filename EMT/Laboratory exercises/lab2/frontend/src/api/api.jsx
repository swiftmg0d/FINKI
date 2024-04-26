import { instance } from "../custom-axios/axios";
export const accommodationsService = {
  getAccommodations: () => {
    return instance.get("/accommodations/listAccommodations");
  },
  reserveAccommodation: (id) => {
    return instance.post(`/accommodations/reserve/${id}`);
  },
  getAccommodationCategories: () => {
    return instance.get("/accommodations/categories");
  },
  getHosts: () => {
    return instance.get("/host/list");
  },
  addAccommodation: (name, category, num0fRooms, host) => {
    return instance.post("/accommodations/add", {
      name: name,
      category: category,
      num0fRooms: num0fRooms,
      host: host,
    });
  },
  deleteAccommodation: (id) => {
    return instance.post(`/accommodations/delete/${id}`);
  },
  editAccommodation: (id, name, category, num0fRooms, host) => {
    return instance.post(`/accommodations/edit/${id}`, {
      name: name,
      category: category,
      num0fRooms: num0fRooms,
      host: host,
    });
  },
  getAccommodation: (id) => {
    return instance.get(`/accommodations/${id}`);
  },
};
