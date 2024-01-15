// Fetch data from a given URL
async function fetchData(url) {
  const response = await fetch(url);
  return await response.json();
}
module.exports = { fetchData };
