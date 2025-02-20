import { faMapMarkedAlt } from "@fortawesome/free-solid-svg-icons";
import { Form, Formik } from "formik";
import { FormattedMessage } from "react-intl";
import { GeofenceCircle } from "../../../../ui/map/geofence/GeofenceCircle";
import { Map } from "../../../../ui/map/Map";
import { MapMove } from "../../../../ui/map/MapMove";
import { CircleGeofence, LongLat } from "../../../../ui/map/types";
import { Modal } from "../../../../ui/modal/Modal";
import { FilterModal } from "../FilterModal";
import { useGeofenceFilter } from "./useGeofenceFilter";

interface IGeofenceFilterModal {
  initialMapCenter?: LongLat;
  filterKey: string;
}

export function GeofenceFilterModal(props: IGeofenceFilterModal) {
  const {
    state,
    handleSubmit,
    close,
    initialValues,
    handleMapMove,
    center,
    zoom
  } = useGeofenceFilter(props.filterKey, props.initialMapCenter);

  return (
    <Modal
      open={state.open}
      close={close}
      className="flex max-w-screen-md flex-grow">
      <Formik<CircleGeofence>
        initialValues={initialValues}
        onSubmit={handleSubmit}>
        {({ values, setValues }) => (
          <Form className="flex flex-grow">
            <FilterModal
              icon={faMapMarkedAlt}
              onCancel={close}
              className="flex min-w-full flex-col">
              <h3 className="text-lg font-medium leading-6 text-gray-900">
                <FormattedMessage id="locations.filter.geofence.title" />
              </h3>
              <div className="mt-4 flex flex-grow" style={{ height: "400px" }}>
                <Map center={center} initialZoom={zoom}>
                  <MapMove onMove={handleMapMove} />
                  <GeofenceCircle geofence={values} onChange={setValues} />
                </Map>
              </div>
            </FilterModal>
          </Form>
        )}
      </Formik>
    </Modal>
  );
}
