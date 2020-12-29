<template>
  <div class="new_score_form">
    <h1>Your total score</h1>
    <form @submit.prevent="submitScore">
      <input type="text" v-model="nickname" />
      <button type="submit">Submit</button>
    </form>
  </div>
</template>
<script>
export default {
  data() {
    return {
      nickname: "",
    };
  },
  methods: {
    submitScore() {
      //pictures json
      var pictures = window.localStorage.getItem("pictures");

      const data = {
        nickname: this.nickname,
        answers: JSON.parse(pictures),
      };

      console.log(data);

      fetch("http://localhost:5000/api/score", {
        method: "POST", // or 'PUT'
        headers: {
          "Content-Type": "application/json",
        },
        body: JSON.stringify(data),
      })
        .then((response) => response.json())
        .then((data) => {
          console.log("Success:", data);
          this.$router.push("/score");
        })
        .catch((error) => {
          console.error("Error:", error);
        });
    },
  },
};
</script>

<style scoped>
.new_score_form {
  width: 5rem;
  height: 5rem;
  background-color: bisque;
}
</style>