export function Copyright() {
  return (
    <span>
      © {new Date().getFullYear()}{" "}
      <a
        href="https://keeano.com"
        target="_blank"
        rel="noreferrer"
        title={import.meta.env.VITE_VERSION}>
        Keeano
      </a>
    </span>
  );
}
