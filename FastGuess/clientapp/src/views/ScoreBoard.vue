<template>
  <div>
    <h1>ScoreBoard</h1>
    <table>
      <tr>
        <th>Nickname</th>
        <th>Date</th>
        <th>Score</th>
      </tr>
      <tr v-for="user in data" v-bind:key="user.nickname">
        <td>{{user.Nickname}}</td>
        <td>{{user.Date}}</td>
        <td>{{user.score}}</td>
      </tr>
    </table>
  </div>
</template>
<script>
export default {
  data() {
    return {
      data: "",
    };
  },
  methods: {
    submitScore() {
      fetch("http://localhost:5000/api/score", {
        method: "GET", // or 'PUT'
      })
        .then((response) => response.json())
        .then((data) => {
          console.log("Success:", data);
          this.data = data;
        })
        .catch((error) => {
          console.error("Error:", error);
        });
    },
  },
};
</script>

<style scoped>
.new_score_form{
    width: 5rem;
    height: 5rem;
    background-color: bisque;
}
</style>