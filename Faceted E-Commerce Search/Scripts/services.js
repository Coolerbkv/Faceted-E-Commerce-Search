var phonecatServices = angular.module('phonecatServices', ['ngResource']);

phonecatServices.factory('Product', ['$resource',
  function ($resource) {
      return $resource('api/Products/Product/:PhoneId', {}, {
          query: { method: 'GET', params: { PhoneId: 'api/Products/Get' }, isArray: false }
      });
  }])

phonecatServices.factory('Filter', ['$resource',
function ($resource, Id) {
    return $resource('/api/Products/filter', {}, {
          query: {
              method: 'POST', isArray: false
          }
      });
  }])

phonecatServices.factory('Colors', ['$resource',
  function ($resource) {
      return $resource('api/Products/GetColors', {}, {
          query: { method: 'GET', isArray: true }
      });
  }])

phonecatServices.factory('Makers', ['$resource',
  function ($resource) {
      return $resource('api/Products/GetMakers', {}, {
          query: { method: 'GET', isArray: true }
      });
  }])

phonecatServices.factory('OSs', ['$resource',
  function ($resource) {
      return $resource('api/Products/GetOSs', {}, {
          query: { method: 'GET', isArray: true }
      });
  }])

phonecatServices.factory('CPUs', ['$resource',
  function ($resource) {
      return $resource('api/Products/GetCPUs', {}, {
          query: { method: 'GET', isArray: true }
      });
  }])

phonecatServices.factory('Diagonals', ['$resource',
  function ($resource) {
      return $resource('api/Products/GetDiagonals', {}, {
          query: { method: 'GET', isArray: true }
      });
  }])

phonecatServices.factory('GPUs', ['$resource',
  function ($resource) {
      return $resource('api/Products/GetGPUs', {}, {
          query: { method: 'GET', isArray: true }
      });
  }])

phonecatServices.factory('RAMs', ['$resource',
  function ($resource) {
      return $resource('api/Products/GetRAMs', {}, {
          query: { method: 'GET', isArray: true }
      });
  }])

phonecatServices.factory('ReleaseYears', ['$resource',
  function ($resource) {
      return $resource('api/Products/GetReleaseYears', {}, {
          query: { method: 'GET', isArray: true }
      });
  }])

phonecatServices.factory('ResolutionScreens', ['$resource',
  function ($resource) {
      return $resource('api/Products/GetResolutionScreens', {}, {
          query: { method: 'GET', isArray: true }
      });
  }])