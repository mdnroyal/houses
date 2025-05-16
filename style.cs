* {
  margin: 0;
  padding: 0;
  box-sizing: border-box;
}

body {
  font-family: 'Segoe UI', sans-serif;
  background: #f4f4f4;
  color: #333;
  line-height: 1.6;
}

header {
  display: flex;
  justify-content: space-between;
  align-items: center;
  background: #0a74da;
  color: white;
  padding: 1rem 2rem;
  position: sticky;
  top: 0;
}

header .logo {
  font-size: 1.5rem;
  font-weight: bold;
}

nav a {
  margin-left: 1rem;
  color: white;
  text-decoration: none;
}

.hero {
  background: url('balaton.jpg') no-repeat center center/cover;
  color: white;
  padding: 100px 20px;
  text-align: center;
}

.hero h1 {
  font-size: 3rem;
}

.hero .btn {
  margin-top: 20px;
  padding: 10px 20px;
  background: #ff7b00;
  color: white;
  border: none;
  border-radius: 5px;
  text-decoration: none;
}

.apartmanok {
  padding: 50px 20px;
  background: white;
  text-align: center;
}

.cards {
  display: flex;
  flex-wrap: wrap;
  justify-content: center;
  gap: 2rem;
  margin-top: 20px;
}

.card {
  background: #fff;
  border-radius: 10px;
  overflow: hidden;
  box-shadow: 0 2px 10px rgba(0,0,0,0.1);
  max-width: 300px;
}

.card img {
  width: 100%;
  height: 200px;
  object-fit: cover;
}

.card h3 {
  margin: 1rem;
}

.card p {
  margin: 0 1rem 1r
