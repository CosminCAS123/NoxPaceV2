<script setup>
  const logoPath = "/NoxPaceLogo.png";
</script>

<template>

  <div class="hero-container">

    <img :src="logoPath" alt="NoxPace Logo" class="knight flip-horizontal" />

    <div class="text-content">
      <h1 class="title">NoxPace</h1>
      <h2 class="subtitle">Conquer your chaos.</h2>
      <button class="cta-button">Start your journey</button>
      <p class="tool-description">The ultimate hyperfocus tool designed for ADHD.</p>
    </div>

    <img :src="logoPath" alt="NoxPace Logo" class="knight" />

  </div>
  <a href="/login" class="login-link">Log In</a>  
</template>

<style scoped>
  .login-link {
    /* Positioning */
    position: fixed;
    top: 30px;
    right: 50px;

    /* Styling */
    font-size: 1rem;
    font-weight: 600;
    text-decoration: none;
    color: #c7a44f; /* Dark gray text */
    padding: 10px 15px;
   
    transition: color 0.2s ease;
  }

    .login-link:hover {
      color: #ffd700;
   
    }
  .tool-description {
    font-size: 1.3em;
    margin-top: 30px; /* Space below the button */
    color: #333; /* Dark gray for subtle visibility */
    opacity: 0.85; /* Make it slightly muted */
  }
  .hero-container {
    height: 100vh;
    width: 100%;

    /* Layout: Push items apart to edges */
    display: flex;
    justify-content: space-between;
    align-items: center;
    /* Add padding so knights don't touch the browser edge */
    padding: 0 5%;
    box-sizing: border-box;
    background: radial-gradient(circle, #E90101 0%, #312E2E 100%);
    color: black;
    text-align: center;
    overflow: hidden; /* Prevents scrollbars if knights get too big */
  }

  .text-content {
    /* Keeps text in the absolute center */
    z-index: 10;
    display: flex;
    flex-direction: column;
    align-items: center;
  }

  .title {
    font-size: 5rem; /* Made slightly bigger */
    font-weight: 800;
    margin: 0;
    letter-spacing: 2px;
    text-shadow: 0 4px 10px rgba(0,0,0,0.3);
  }

  .subtitle {
    font-size: 1.5rem;
    margin-top: 10px;
    margin-bottom: 40px;
    /* New Color: Deep, dark crimson */
    color: #000000;
    font-weight: 600; /* Made it Semi-Bold for better visibility */
  }

  /* Ugly Border Fix: Adding some padding, fixing the border and hover */
  /* Styling for the default (non-hovered) state */
  /* Update the default button style (not hover) */
  .cta-button {
    padding: 15px 40px;
    font-size: 1.1rem;
    font-family: inherit;
    /* CHANGE: Solid Dark Background */
    background-color: #1A1A1A;
    /* CHANGE: White Text for high contrast */
    color: white;
    /* Border stays dark red */
    border: 2px solid #8B0000;
    cursor: pointer;
    transition: all 0.3s ease-in-out;
    box-shadow: 0 0 10px rgba(139, 0, 0, 0.5);
  }

    /* Update the button hover style */
    /* Update the button hover style */
    /* Update the button hover style */
    /* Update the button hover style */
    /* HOVER STATE: Simple, contrasting dark gray */
    .cta-button:hover {
      /* CHANGE: Use a medium-dark gray that contrasts with the default #1A1A1A */
      background-color: #313131;
      /* Keep text white */
      color: white;
      /* Keep the border and box shadow the same as the default state */
      border-color: #8B0000;
      box-shadow: 0 0 10px rgba(139, 0, 0, 0.5);
    }

  /* KNIGHT STYLES */
  .knight {
    /* Huge Size */
    height: 70vh;
    width: auto;
    /* Filter to blend them slightly or make them pop */
    filter: drop-shadow(0 0 20px rgba(0,0,0,0.6));
  }

  /* UTILITY CLASS FOR FLIPPING */
  .flip-horizontal {
    transform: scaleX(-1);
  }
</style>
