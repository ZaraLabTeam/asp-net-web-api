### API Endpoints

| Action            | HTTP Method | Relative URL              | Method                        |
|-------------------|-------------|---------------------------|-------------------------------|
| Get list of jokes | GET         | /api/jokes                | Get(int start, int end)       |
| Get a joke by ID  | GET         | /api/jokes/{id}           | Get(int id)                   |
| Create a joke     | POST        | /api/jokes                | Create(JokeCreateModel model) |
| Get Random Jokes  | GET         | /api/jokes/random/{count} | Random(int count)             |
<!-- .element style="font-size: 43px;" -->