// Utilities for array operations
function removeDuplicates(array) {
  return [...new Set(array)];
}
module.exports = { removeDuplicates };
