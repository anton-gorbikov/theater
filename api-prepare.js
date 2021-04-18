const fs = require('fs');

fs.mkdirSync('dist/api', { recursive: true });
fs.copyFileSync('src/api/package.json', 'dist/api/package.json');
