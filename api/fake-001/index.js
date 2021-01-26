const express = require('express');

const app = express();
const port = 3000;


app.use(express.urlencoded({ extended: true }));
app.use(express.json());

app.get('/', (req, res) => res.send('Hello World!'));

app.post('/', (req, res) => {
    res.send('OK');
});

app.post('/wookies', (req, res) => {
    res.send('OK');
});

app.get('/wookie/:id', (req, res) => {
    res.statusCode = 200;
    
    res.send({
        id: parseInt(req.params.id),
        surname: 'chewie_' + req.params.id,
        size: 0,
        data: [
            {
                key: 'weapon',
                value: req.query.key
            }
        ]
    });
});

app.listen(port, () => console.log(`Example app listening at http://localhost:${port}`));